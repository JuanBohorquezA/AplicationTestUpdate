   M S B A M L   `   `   `  ���� J  FhantleDispenser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:hantleDispenser.UserControlshantleDispenser.UserControls  6    0hantleDispenser.UserControls.DispendQuantitiesUC   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  6local*clr-namespace:hantleDispenser.UserControls  .���    	DARKTHEME#��[    � RowDefinitions  ��   RowDefinitionHeight#���  �� $��* ��� #���  .+�� $��0��  �� $��* ��� $��* �.+��� $��0��$��APP SOPORTES��$��Center=�$��Bottom=�  CommonFontSize#���  $��SemiBold"�  
LIGTHCOLOR#��[ �� -    ��Name$ 
txtMessage��$��1��$/��)*INGRESE UNA CANTIDAD A DISPENSAR VALIDA*��$��Center=� �� TextAlignment$ Center=�$
��Wrap=�#���  $��SemiBold"�  
ERRORCOLOR#��[ $y�	Collapsed=��� $��1�� �� CornerRadius$ 35��  PRIMARYCOLOR#��[ ._��  � ColumnDefinitions �� $��* ��� $��5* ��� $��5* ��� $��* �.+��� -    ��Name$ DispendValueBorder��$��1��$��2��$ 35��$��3q�  SECONDARYCOLOR#��[   TERTIARYCOLOR#��[   MinMarginGrid#���  ._��   �� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��  	 
MarginGrid#��� 	 $��0��$��Bottom=�  �� $��* �.+��� -   $ txtInputValue��$��0��$6��0Por favor Indique el valor a dispensar por baúl��$
��Wrap=�$��Bottom=�$ Center=�#���  $��SemiBold"�$y�Visible=�#��[ � #��� 	 $��1��$��4��  �� $��* ��� $��* ��� $��* ��� $��* �.+�� $��0��$��Bottom=� �� $��* ��� $��* ��� $��* �.+��� $��0��$��Denominación�� 
 
CommonText#��[
 �� $��1��$��Cantidad��#��[
 �� $��2��$��Acciones��#��[
 �� -    ��Name$ DataView��$��1��$��3��  MyListBoxItemStyle#��[ 
������ $��0q����� .R��� ._��   MinButtonHeight#���  #���   �� $��* ��� $��* ��� $��* �.+�� $��0�� �� $��* ��� $	��10* ��� $��* �.+��� $��1��  DispendButton#��[ ._���   DispenTextButton#��[ ���� *Denomination+ �� StringFormat$
 ${0}��� $��1�� �� $��* ��� $	��10* ��� $��* �.+��� $��1��#��[ ._��� #��[ ���� *
Quantity+� $��2�� �� $��* ��� $��5* ��� $��* ��� $��5* ��� $��* �.+��� -   $��1�� � Cursor$
 Hand��#��[ ._��� $��+��#��[ $
��Bold"��� -   $��3��$
 Hand��#��[ ._��� $��-��#��[ $
��Bold"�� $��2�� �� $��* ��� $��* �.+�0   *hantleDispenser.UserControls.GenericButton  0   *hantleDispenser.UserControls.GenericButton	   PreviewMouseDown$	 BtnContinue��$��0��
   ButtonBackground#
 [    
ButtonText$ 	Dispensar��$��Center=�$��Center=�  ButtonHeightMenu   ButtonHeight# �    ButtonWidthMenu   ButtonWidth# �    $	 BtnCancelar��$��1��#
 [ $ Cancelar��$��Center=�$��Center=�# �  # �  