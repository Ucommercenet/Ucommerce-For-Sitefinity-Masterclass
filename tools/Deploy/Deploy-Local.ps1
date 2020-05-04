# Website root folder (website is deployed here)
$website_root = "C:\inetpub\Sitefinity\Website\CMS"

# Temporarily change to the correct folder containing script
$scriptPath = (Get-Variable MyInvocation -Scope Script).Value.MyCommand.Path
$currentFolder = Split-Path $scriptPath
Push-Location $currentFolder

# Set src folder based on location of script location in /tools/deploy
$src = ".\..\..\src\UCommerce.Masterclass.Website"

# Exclude files and folders from deploy, usually these are
# source code files, proj files from Visual Studio, and other
# files not required at runtime
$options = @("/E", "/S", "/xf", "*.cs", "/xf", "*.??proj", "/xf", "*.user", "/xf", "*.old", "/xf", "*.vspscc", "/xf", "xsltExtensions.config", "/xf", "uCommerce.key", "/xf", "*.tmp", "/xd", "_Resharper*", "/xd", ".svn", "/xd", "_svn", "/xf", "UCommerce.dll", "/xf", "UCommerce.Presentation.dll", "/xf", "UCommerce.Web.Api.dll", "UCommerce.Infrastructure.dll", "/xf", "UCommerce.Transactions.Payments.dll", "/xf", "UCommerce.Pipelines.dll", "/xf", "ServiceStack.*")

# Copy all site specific files into the website
& robocopy "$src\bin" "$website_root\bin" UCommerce.Masterclass*.dll $options
& robocopy "$src\bin\" "$website_root\bin" WebActivatorEx*
& robocopy "$src\bin\" "$website_root\bin" Telerik*
& robocopy "$src\UCommerce\" "$website_root\UCommerce" $options
# Now back to original directory
Pop-Location