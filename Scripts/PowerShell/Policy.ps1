Write-Host "Warning: This script is for demonstration purposes only. It is not intended for production use and may contain security vulnerabilities. Use at your own risk."

# Define a function to check if the current user has administrative privileges

$CURRENT_USER = [Security.Principal.WindowsIdentity]::GetCurrent();

Write-Host "Current user: $($CURRENT_USER.Name)"