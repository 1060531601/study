VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3015
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4560
   LinkTopic       =   "Form1"
   ScaleHeight     =   3015
   ScaleWidth      =   4560
   StartUpPosition =   3  '´°¿ÚÈ±Ê¡
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()

Dim dMiinjiBi(12, 31) As Boolean

Dim injibi As Date

 dMiinjiBi(Format("2021/12/22", "MM"), Format("2021/12/22", "DD")) = True
 
 If dMiinjiBi(Format("2021/12/21", "MM"), Format("2021/12/21", "DD")) = True Then
 
 injibi = "2021/12/21"
 
 
 End If
 
 
 
 

End Sub
