   M S B A M L   `   `   `  ????D  @WpfGroup1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WpfGroup1	WpfGroup1  5          WpfGroup1.PageUser   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:WpfGroup1     5        N? Title$  PageUser??5	       N? 
Background
 ?????.??5      ?  ? ColumnDefinitions 5   
   ?? 5      ?? 5      ?? 5       ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      ?? 5      ?? 5      .+?5   
   ?? -   5         ??Name$ ComboBoxSort??5      $	??250??6)   $??30??65   $??2q?6A   .@?5      ?? $??Все??6   ?? 5      $??По убыванию??6   ?? 5      $!??По возрастанию??6   ?? 5      $#??Цена больше 2000р.??6   5      ?? 5   
   -   5         ??Name$ TextBoxF??5      $	??250??6$   $??1??60   $??2q?6@   6K   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
MyDataGrid??5      $??1??5       $??3??6    $??3??5!         AutoGenerateColumns .     Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Наименование??6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   ?? *Title+  5%      $	 Цена??6%   
 63   ?? *Price+  5&      $	 Количество??6%   
 69   ?? *Count+  5'      $$	 Стоимость за все??6%   
 6?   ?? *	FullPrice+5)      5*      5+      