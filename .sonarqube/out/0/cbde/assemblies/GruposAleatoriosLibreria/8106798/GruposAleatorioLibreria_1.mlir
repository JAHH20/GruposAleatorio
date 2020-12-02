func @_GruposAleatoriosLibreria.Randomizer.Randomize$T$$T$$$(none) -> () loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :11 :8) {
^entry (%_items : none):
%0 = cbde.alloca none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :11 :40)
cbde.store %_items, %0 : memref<none> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :11 :40)
br ^0

^0: // ForInitializerBlock
%1 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :13 :26) // new Random() (ObjectCreationExpression)
%3 = constant 0 : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :15 :25)
%4 = cbde.alloca i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :15 :21) // i
cbde.store %3, %4 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :15 :21)
br ^1

^1: // BinaryBranchBlock
%5 = cbde.load %4 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :15 :28)
%6 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :15 :32) // Not a variable of known type: items
%7 = cbde.unknown : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :15 :32) // items.Length (SimpleMemberAccessExpression)
%8 = constant 1 : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :15 :47)
%9 = subi %7, %8 : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :15 :32)
%10 = cmpi "slt", %5, %9 : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :15 :28)
cond_br %10, ^2, ^3 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :15 :28)

^2: // SimpleBlock
%11 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :17 :24) // Not a variable of known type: rand
%12 = cbde.load %4 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :17 :34)
%13 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :17 :37) // Not a variable of known type: items
%14 = cbde.unknown : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :17 :37) // items.Length (SimpleMemberAccessExpression)
%15 = cbde.unknown : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :17 :24) // rand.Next(i, items.Length) (InvocationExpression)
%16 = cbde.alloca i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :17 :20) // j
cbde.store %15, %16 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :17 :20)
%17 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :18 :25) // Not a variable of known type: items
%18 = cbde.load %4 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :18 :31)
%19 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :18 :25) // items[i] (ElementAccessExpression)
%21 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :19 :16) // Not a variable of known type: items
%22 = cbde.load %4 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :19 :22)
%23 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :19 :16) // items[i] (ElementAccessExpression)
%24 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :19 :27) // Not a variable of known type: items
%25 = cbde.load %16 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :19 :33)
%26 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :19 :27) // items[j] (ElementAccessExpression)
%27 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :20 :16) // Not a variable of known type: items
%28 = cbde.load %16 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :20 :22)
%29 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :20 :16) // items[j] (ElementAccessExpression)
%30 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :20 :27) // Not a variable of known type: temp
br ^4

^4: // SimpleBlock
%31 = cbde.load %4 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :15 :50)
%32 = constant 1 : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :15 :50)
%33 = addi %31, %32 : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :15 :50)
cbde.store %33, %4 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :15 :50)
br ^1

^3: // ExitBlock
return

}
func @_GruposAleatoriosLibreria.numeroExcel.GetExcelColumnName$int$(i32) -> none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :27 :4) {
^entry (%_columnNumber : i32):
%0 = cbde.alloca i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :27 :37)
cbde.store %_columnNumber, %0 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :27 :37)
br ^0

^0: // SimpleBlock
%1 = cbde.load %0 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :29 :23)
%2 = cbde.alloca i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :29 :12) // dividend
cbde.store %1, %2 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :29 :12)
// Entity from another assembly: String
%3 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :30 :28) // String.Empty (SimpleMemberAccessExpression)
%5 = cbde.alloca i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :31 :12) // modulo
br ^1

^1: // BinaryBranchBlock
%6 = cbde.load %2 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :33 :15)
%7 = constant 0 : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :33 :26)
%8 = cmpi "sgt", %6, %7 : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :33 :15)
cond_br %8, ^2, ^3 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :33 :15)

^2: // SimpleBlock
%9 = cbde.load %2 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :35 :22)
%10 = constant 1 : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :35 :33)
%11 = subi %9, %10 : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :35 :22)
%12 = constant 26 : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :35 :38)
%13 = remis %11, %12 : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :35 :21)
cbde.store %13, %5 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :35 :12)
// Entity from another assembly: Convert
%14 = constant 65 : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :36 :40)
%15 = cbde.load %5 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :36 :45)
%16 = addi %14, %15 : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :36 :40)
%17 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :36 :25) // Convert.ToChar(65 + modulo) (InvocationExpression)
%18 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :36 :25) // Convert.ToChar(65 + modulo).ToString() (InvocationExpression)
%19 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :36 :66) // Not a variable of known type: columnName
%20 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :36 :25) // Binary expression on unsupported types Convert.ToChar(65 + modulo).ToString() + columnName
%21 = cbde.load %2 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :37 :30)
%22 = cbde.load %5 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :37 :41)
%23 = subi %21, %22 : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :37 :30)
%24 = constant 26 : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :37 :51)
%25 = divis %23, %24 : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :37 :29)
%26 = cbde.unknown : i32 loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :37 :23) // (int)((dividend - modulo) / 26) (CastExpression)
cbde.store %26, %2 : memref<i32> loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :37 :12)
br ^1

^3: // JumpBlock
%27 = cbde.unknown : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :40 :15) // Not a variable of known type: columnName
return %27 : none loc("D:\\FindeCurso\\GruposAleatoriosLibreria\\GruposAleatorioLibreria.cs" :40 :8)

^4: // ExitBlock
cbde.unreachable

}
