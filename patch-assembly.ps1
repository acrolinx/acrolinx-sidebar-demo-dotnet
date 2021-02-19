$tagName = git describe --tags
$hasVersionSchema = $tagName -match 'v(\d+)\.?(\d*)\.?(\d*)\.?(\d*)'
$main = [Int] (0 + $Matches.1)
$major = [Int] (0 + $Matches.2)
$minor = [Int] (0 + $Matches.3)
$build = [Int] (0 + $Matches.4)
if (!$hasVersionSchema)
{
    Write-Output "tag '$tagName' doesn't match version schema x.x.x.x"
    exit 1
}
$version = [String] $main + "." + $major + "." + $minor + "." + $build

function PatchAssemblyVersions{
    param (
        $version,
        $file
    )
    $content = Get-Content -path $file
    $content = $content -replace 'AssemblyVersion\(\"\d+\.\d+\.\d+\.\d+\"\)',('AssemblyVersion("' + $version + '")')
    $content = $content -replace 'AssemblyFileVersion\(\"\d+\.\d+\.\d+\.\d+\"\)',('AssemblyFileVersion("' + $version + '")')
    Set-Content -path $file -Value $content -Encoding UTF8
    Write-Output "Patched file '$file' to version: $version"
}

PatchAssemblyVersions -version $version -file 'Acrolinx.Demo.Sidebar\Properties\AssemblyInfo.cs'
