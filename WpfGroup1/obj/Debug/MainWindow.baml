   M S B A M L   `   `   `  ????D  @WpfGroup1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WpfGroup1	WpfGroup1  5   	       WpfGroup1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WpfGroup1     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $??30 ?6   ?? 5      $
??Auto ?6   ?? 5      $??1* ?6   ?? 5      $??30 ?6    ? RowDefinitions 5   
   ?? 5      $??30 ?6   ?? 5      ?? 5      ?? 5      ?? 5      $??30 ?6   .+?5   
   ?? $??Login??6   $??1??6    $??1??6-   $??36(?6=   $??Center=?6K   $??Center=?6h   ?? 5   
   $??Password??6   $??2??6#   $??1??60   $??36(?6@   $??Center=?6N   $??Center=?6k   ?? 5   
   -   5         ??Name$ TextBoxLogin??5      $??1??6(   $??2??65   $??5q?6E   $??36(?6P   ?? 5   
   -   5        $ TextBoxPassword??5      $??2??6+   $??2??68   $??5q?6H   $??36(?6S   ?? 5   
   -   5         ??Name$ Button??5      $??3??6!   $??1??6.   $??2??6>   $??10q?6R   $??
Войти??6^   $??36(?6n   6|   ?? 5   
   $??5??6   
????? ?6!   ?? 5   
   $??5??6   $??4??6!   
????? ?61   ?? 5   
   $??5??6   
????? ?6$   ?? 5   
   $??5??6   
????? ?$??4??6/    ? 5    
   -   5          ?Name$ MyFrame??5       $??4??6!   $??5??65     ? NavigationUIVisibility$ Hidden=?6F   6h   5!      5"      