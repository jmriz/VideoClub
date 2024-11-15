;#DropDB VideoClubEasyTest

#Application VideoClubWin
;#Application VideoClubWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef VideoClubWin

*Action About...
 
*Action OK

#EndIf

#IfDef VideoClubWeb
*Action Navigation(My Details)
#EndIf
