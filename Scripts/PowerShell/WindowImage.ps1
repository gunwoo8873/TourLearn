Write-Host " Checking for Windows image health"
DISM /Online /Cleanup-Image /CheckHealth

Write-Host " Scanning for Windows image health issues"
DISM /Online /Cleanup-Image /ScanHealth

Write-Host " Restoring Windows image health"
DISM /Online /Cleanup-Image /RestoreHealth

Write-Host " Running System File Checker to repair any corrupted system files"
sfc /scannow
