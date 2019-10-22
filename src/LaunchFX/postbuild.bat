$(ProjectDir)..\..\pdb2mdb\pdb2mdb.exe $(TargetPath)
if not exist "$(SolutionDir)\..\GameData\$(TargetName)" mkdir "$(SolutionDir)\..\GameData\$(TargetName)\"
if not exist "$(SolutionDir)\..\GameData\$(TargetName)\Plugins" mkdir "$(SolutionDir)\..\GameData\$(TargetName)\Plugins\"

copy /y $(TargetDir)$(TargetName)* $(SolutionDir)\..\GameData\$(TargetName)\Plugins 
copy /y $(ProjectDir)$(TargetName).version $(SolutionDir)\..\GameData\$(TargetName)\