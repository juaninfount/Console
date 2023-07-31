rem (powershell)
rem Encontrar carpetas obj/bin de forma recursiva y eliminarlas:
Get-ChildItem .\ -include bin,obj -Recurse | foreach ($_) { remove-item $_.fullname -Force -Recurse }