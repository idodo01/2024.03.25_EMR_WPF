   M S B A M L   `   `   `  ����>  :EMR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:EMR.Views.PagesEMR.Views.Pages  5      'clr-namespace:EMR.Models
EMR.Models  5      ;"clr-namespace:EMR.ViewModels.PagesEMR.ViewModels.Pages  5	   7       EMR.Views.Pages.StaffPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:EMR.Views.Pages     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      +modelsclr-namespace:EMR.Models     5      A =Wpf.Ui, Version=3.0.4.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml  5	      .pages"clr-namespace:EMR.ViewModels.Pages  67     N� Title$  	StaffPage��5
         ApplicationBackgroundBrush  Wpf.Ui.Markup.Design   
Background# �   5        TextFillColorPrimaryBrush   
Foreground# �  5       N� 
Foreground# �  5      $��False��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $��* �6   .+�5   
   � $��0��6   $��10q�6   .+�5      �� ��6   �� *ViewModel.Staffs+ �� SelectedItem 5      �� *SelectedStaff+��5      �� 5      .R�5       �� .+�5!      �� ��6(   �� *Name+�� 5"      ��6(   �� *
Position+5$      5%      5'      5(      � 5+   
   $��1��6   $��10q�6   .+�5,      �� .+�5-      �� $��Staff Detail��6   $��18(�60   $
��Bold"�6>   $��0,0,0,10q�6P   �� 5/       �� Orientation$ Vertical=�6   $��0,0,0,10q�64   .+�50      �� $��Name:��6    $
��Bold"�6-   �� 51      ��6    �� *SelectedStaff.Name+�� 53      $��Department:��6    $
��Bold"�63   �� 54      ��6    �� *SelectedStaff.Department+�� 56      $��	Position:��6    $
��Bold"�61   �� 57      ��6    �� *SelectedStaff.Position+�� 59      $
��Age:��6    $
��Bold"�6,   �� 5:      ��6    �� *SelectedStaff.Age+5;      �� 5=      $��Email:��6   $
��Bold"�6*   �� 5>      $��0,0,0,10q�6A   ��6   �� *SelectedStaff.Email+6A   �� 5@      $��Phone:��6   $
��Bold"�6*   �� 5A      $��0,0,0,10q�6A   ��6   �� *SelectedStaff.Phone+6A   5B      5C      5D      5E      