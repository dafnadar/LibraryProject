   M S B A M L   `   `   `  ????D  @MyLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MyLibrary.ViewMyLibrary.View  5   	   $    MyLibrary.View.EditJournalView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:MyLibrary.View     5   	     ? Title$  EditJournalView??5   	   $	??450??6!   $	??800??6.    ? DataContext 5	      ??    Locator ?? Source# [   ?? Path$ EditJournal?.??5      ?  ? ColumnDefinitions 5   
   ?? 5      ?? 5       ? RowDefinitions 5   
   ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      .+?5   
   ?? $??Title:??6   $??0??6"   ?? 5   
   $??Price:??6   $??1??6"   $??0??6/   ?? 5   
   $??Subject:??6   $??2??6$   $??0??61   ?? 5   
   $??Copies:??6   $??3??6#   $??0??60   ?? 5   
   $??Sheet:??6   $??4??6"   $??0??6/   ?? 5   
   $??Print Date:??6   $??5??6'   $??0??64   ?? 5!   
   $?? ??6   $??1??6   ?? 5"   
   $?? ??6   $??1??6   $??1??6'   ?? 5#   
   $?? ??6   $??2??6   $??1??6'   ?? 5$   
   $?? ??6   $??3??6   $??1??6'   ?? 5%   
   $?? ??6   $??4??6   $??1??6'   ?? 5&   
   $?? ??6   $??5??6   $??1??6'   ?? 5(   
   $??7??6   $
??Save??6   ??6-   ?? *SaveCommand+5*      5+      