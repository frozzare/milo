# encoding: utf-8
require 'rubygems'
require 'albacore'
require 'rake/clean'

OUTPUT = 'build'
OUTPUT_ASSEMBLY = 'src/SharedAssemblyInfo.cs'
CONFIGURATION = 'Release'
CONFIGURATIONMONO = 'MonoRelease'
SOLUTION_FILE = 'src/Milo.sln'

Albacore.configure do |config|
    config.log_level = :verbose
    config.msbuild.use :net4
end

desc 'Update shared assemblyinfo file for the build'
assemblyinfo :assembly_info => [:clean] do |asm|
    asm.company_name = 'Milo'
    asm.product_name = 'Milo'
    asm.title = 'Milo'
    asm.description = 'A content management system for the .NET platform'
    asm.copyright = 'Copyright (C) Fredirk Forsmo, Caroline Millgårdh and contributors'
    asm.output_file = OUTPUT_ASSEMBLY
    asm.version = '0.1.0'
end

desc 'Compile solution file'
msbuild :compile => [:assembly_info] do |msb|
    msb.properties = { :configuration => CONFIGURATION, 'VisualStudioVersion' => ENV['VS110COMNTOOLS'] ? '11.0' : '10.0' }
    msb.targets :Clean, :Build
    msb.solution = SOLUTION_FILE
end

desc 'Compile solution file for Mono'
xbuild :compilemono => [:assembly_info] do |xb|
    xb.solution = SOLUTION_FILE
    xb.properties = { :configuration => CONFIGURATIONMONO, 'TargetFrameworkProfile' => '', 'TargetFrameworkVersion' => 'v4.0' }
end