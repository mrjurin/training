Imports TrainingOop

Module Module1
    'Standard
    'Pascal Style:CapitalCapital()
    'Constant Style:ABC
    'CamelCase Style: lowercaseCapital()
    'Verb/Expressive


    'Dynamic Language
    'Strongly-Typed Language

    Dim camelCase As String = "" 'Type Safe code



    Sub Main()


        Dim strArr = New String() {"jurin", "malai", "malas", "hisyam"}


        Dim strNama = strArr.Where(Function(x) x.StartsWith("malai")) _
            .Select(Function(x) x.ToUpper())

        Dim strNama1 = strArr.Where(Function(x)
                                        Return x.StartsWith("malai")
                                    End Function)


        If strNama.Any Then
            If strNama.Count() = 1 Then
                For Each n In strNama
                    Console.WriteLine(n)
                Next
            Else
                Console.WriteLine("More than one value")
            End If
        Else
            Console.WriteLine("no value")
        End If





        Dim staffM = New Staff

        Dim salaryCal = New CalculateSalaryExecutive

        'salaryCal.PayperHour = 1000

        staffM.CalculateSalary(salaryCal)

        Console.ReadKey()
    End Sub

End Module
'Abstraction Class

'-----OOP------
'----Encapsulation----(flaw)
' -- Tightly Coupled
'Inheritance
'Polymorphism


'Principle
'- SRP -> Single Responsiblity 
'- Open Closed Principle
'- Liskov Substitution
'- Inversion Of Control
'- Dependency Injection

'--- Gaji seorang pekerja dengan kadar OT yang berbeza ----
'--- Analysis----
'1. Audience-> GeneralStaff, MiddleStaff, ExecutiveStaff > staff
'2. 3 types of salary calculation
'Type: 1->100 /h * 30
'Type: 2->200 /h * 30
'Type: 3->300 /h * 30
'3. 3 types of OT calculation
' T1-> 10% /h, => math error-> decimal point, zero divison
' T2-> 20% /h
' T3-> 30% /h
'Functional and *Non-Functional* Requirements
'-60% functional
'-40% non-function => development timeline
' Quality and Time


'Implementation part
'developer/programmer

'Staff
'CalculateSalary->calculate()
'CalculateOT->calculate()


'Single Responsibility-> only one reason to change a class

'LINQ => Language Integrated Query

Public Interface ICalculateSalary
    Property PayperHour As Decimal
    Sub calculate()
End Interface

Public Class CalculateSalaryGeneral
    Implements ICalculateSalary

    Public Property PayperHour As Decimal Implements ICalculateSalary.PayperHour
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Decimal)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Sub calculate() Implements ICalculateSalary.calculate
        Console.WriteLine("Calculate Using General Calculation")
    End Sub
End Class


Public Class CalculateSalaryDoctor
    Implements ICalculateSalary

    Public Property PayperHour As Decimal Implements ICalculateSalary.PayperHour
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Decimal)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Sub calculate() Implements ICalculateSalary.calculate
        Console.WriteLine("Calculate Using Doctor Calculation")
    End Sub
End Class

Public Class CalculateSalaryMiddle
    Implements ICalculateSalary

    Public Property PayperHour As Decimal Implements ICalculateSalary.PayperHour
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Decimal)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Sub calculate() Implements ICalculateSalary.calculate
        Console.WriteLine("Calculate Using Middle Calculation")
    End Sub
End Class

Public Class CalculateSalaryExecutive
    Implements ICalculateSalary

    Public Property PayperHour As Decimal Implements ICalculateSalary.PayperHour
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Decimal)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Sub calculate() Implements ICalculateSalary.calculate
        Console.WriteLine("Calculate Using Executive Calculation")
    End Sub
End Class

Public Class CalculateOT
    Public Sub calculate()

    End Sub

End Class

Public Class Staff
    Public Property Name As String
    Public Property IC As String
    Public Property TypeOfSalary As Integer
    Public Property Salary As Double
    Public Property OTType As Integer

    Public Sub CalculateSalary(SalaryCalculator As ICalculateSalary)
        SalaryCalculator.calculate()
    End Sub

    Public Sub CalculateOT(SalaryCalculator As ICalculateSalary)
        SalaryCalculator.calculate()
    End Sub
End Class



Public MustInherit Class GeneralDog
    Public Property Name As String
    Public Property Color As String
    Public Property Age As Integer 'Read/Write Property

    Private _Habitat As String

    'field
    Private _VolumeOfBark As Decimal

    Public Sub New()
        Me._Habitat = "Darat"
    End Sub

    'read only
    Public ReadOnly Property GetVolumeOfBarks() As Integer
        Get
            Return Me._VolumeOfBark
        End Get
    End Property

    'Method ada 2 : Void/ReturnType
    'Void method
    Public Sub Bark()
        Console.WriteLine("Barking..")

        Me._VolumeOfBark = Me.calculateVolumeOfBark(20.4)

        Console.WriteLine("Please get the volume")
    End Sub

    'Access modifier
    Private Function calculateVolumeOfBark(ByVal Val As Decimal) As Decimal

        Dim toInt = Math.Round(Val, 1)

        Return toInt
    End Function

    'Can change the behaviour on the specific class
    Public Overridable ReadOnly Property GetHabitat() As String
        Get
            Return Me._Habitat
        End Get
    End Property
End Class

'Concrete class
'Blueprint=> Templating=> object
Public Class Dog
    Inherits GeneralDog
End Class

Public Class Seal
    Inherits Dog 'inheritance

    Private _Habitat As String
    'Constructor
    '__construct(){}
    'Seal(){}
    Sub New()
        Me._Habitat = "Ocean"
    End Sub

    'Overriding
    Public Overrides ReadOnly Property GetHabitat As String
        Get
            Return Me._Habitat
        End Get
    End Property

End Class

Public Class Wolf
    Inherits Dog 'inheritance

    Private _Habitat As String
    'Constructor
    '__construct(){}
    'Seal(){}
    Sub New()
        Me._Habitat = "Iceland"
    End Sub

    'Overriding
    Public Overrides ReadOnly Property GetHabitat As String
        Get
            Return Me._Habitat
        End Get
    End Property

End Class