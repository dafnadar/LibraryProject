   M S B A M L   `   `   `  ????D  @MyLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MyLibrary.ViewMyLibrary.View  5      $    MyLibrary.View.ShowDetailsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:MyLibrary.View     5        ? DataContext  5	      ??    Locator ?? Source# [   ?? Path$ ShowDetails?.??5
      ?  ? RowDefinitions 5   
   ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5       ? ColumnDefinitions 5   
   ?? 5      ?? 5      ?? 5      ?? 5      .+?5   
   ?? $	??ID:??6   $??0??6   ?? 5   
   $??Title:??6   $??1??6"   ?? 5    
   $??Price:??6   $??2??6"   ?? 5!   
   $??Copies:??6   $??3??6#   ?? 5#   
   $??0??65   $??1??6B   ??6   ?? *SelectedItem.Id+6B   ?? 5$   
   $??1??68   $??1??6E   ??6   ?? *SelectedItem.Title+6E   ?? 5%   
   $??2??68   $??1??6E   ??6   ?? *SelectedItem.Price+6E   ?? 5&   
   $??3??69   $??1??6F   ??6   ?? *SelectedItem.Copies+6F   ?? 5)   
   -   5        $??1??5)      $??7??6!   $
??Edit??6.   $??30??6^   ?? 5*   
   $??2??6   $??7??6!   $??Delete??6.   $??30??6a   ??6?   ?? *DeleteCommand+6a   5+      5,      