   M S B A M L   `   `   `  ����a  ]Tekla.Structures.Dialog, Version=2020.0.0.0, Culture=neutral, PublicKeyToken=2f04dbe497b71114xQclr-namespace:Tekla.Structures.Dialog.UIControls;assembly=Tekla.Structures.Dialog"Tekla.Structures.Dialog.UIControls  5   	   bFclr-namespace:Tekla.Structures.Dialog;assembly=Tekla.Structures.DialogTekla.Structures.Dialog  5   	   I EWPFFirstPlugin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFFirstPluginWPFFirstPlugin 5	   	      WPFFirstPlugin.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   h
UIControlsQclr-namespace:Tekla.Structures.Dialog.UIControls;assembly=Tekla.Structures.Dialog     5   	   VtsdFclr-namespace:Tekla.Structures.Dialog;assembly=Tekla.Structures.Dialog     5   	   .localclr-namespace:WPFFirstPlugin     5	   	     � Title$  FirstPlugin��5   	   $	��450��5   	   $	��800��5   	    � 	Resources 5       �� Source�� 5   
   $ FusionTheme.xaml?�6   %    .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   $��48��6*   �� 5      �� 5      $
��Auto �6   $��48��6*   .+�5   
   4   .Tekla.Structures.Dialog.UIControls.WpfSaveLoad  $��0��5       $��0,0,0,0q�5!      $��Stretch=�5"      $	��Top=�5#      � 5%   
   $��1��6    5'      �� 5(      �� 5)      �� 5*       � ColumnDefinitions 5,      �� 5-      �� 5.      .+�51      ��  �� Orientation$ 
Horizontal=�6   .+�52      �� -   5         ��Name$ partNameLabel��53      $	��100��54      $��30��55      $
��Left=�56      $��Center=�57      $
��Name��58      :   4Tekla.Structures.Dialog.UIControls.WpfFilterCheckBox  59      $
��Left=�5:      $��Center=�5;         AttributeName$
 name��5<      �� 5=      -   5         ��Name$ partNameTextBox��5>      $	��120��5?      $��23��5@      $
��Left=�5A      $��Center=�5B      	 �� TextWrapping$
	 Wrap=�5D      ��5C      �� *Name+
 �� Mode$
 TwoWay=�5D      5E      �� 5F      $��1��6   $ 
Horizontal=�6&   .+�5G      �� -   5        $ 
label_Copy��5H      $	��100��5I      $��30��5J      $��Profile��5K        5L      $��Center=�6/   $ profile��6J   �� 5M      -   5        $ textBox_Copy��5N      $	��120��5O      $��23��5P      $��Center=�5Q      $
	 Wrap=�5S      ��5R      �� *	Profile+$
 TwoWay=�5S      :   4Tekla.Structures.Dialog.UIControls.WpfProfileCatalog  5T      -   5          Name$ profileCatalog��5U      $��Center=�5V      5X      5Y      �� 5Z      $��2��6   $ 
Horizontal=�6&   .+�5[      �� -   5        $ label_Material��5\      $	��100��5]      $��30��5^      $
��Left=�5_      $��Center=�5`      $��Material��5a        5b      $
��Left=�5c      $��Center=�5d      $ material��5e      �� 5f      -   5        $ materialBox��5g      $	��120��5h      $��23��5i      $��Center=�5j      $
	 Wrap=�5l      ��5k      �� *
Material+$
 TwoWay=�5l      ;   5Tekla.Structures.Dialog.UIControls.WpfMaterialCatalog  5m      -   5          Name$ materialCatalog��5n      $��Center=�5o      $��0q�5p      $��6(�5q      5s      5t      5u      G   ATekla.Structures.Dialog.UIControls.WpfOkApplyModifyGetOnOffCancel  5w   
   -	   5        $��2��5x      5~      5      5�      