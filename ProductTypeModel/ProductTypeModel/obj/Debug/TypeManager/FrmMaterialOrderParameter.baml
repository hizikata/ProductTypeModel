   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5      "    UI.FrmMaterialOrderParameter   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "localclr-namespace:UI     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��30 �6   �� 5      $
��200* �6   �� 5      $��24 �6   �� 5      $	��99* �6   .+�5   
   � $��0��6   
�������$��1��6.    � ColumnDefinitions 5      �� 5      $	��202 �6#   �� 5      $	��204 �6#   �� 5      $	��147 �6#   �� 5      .+�5      �� $
��Left=�6   $��30��63   $
��Wrap=�6?   $��型号:��6S    �� Padding$ 5q�6^   $	��Top=�6j   $��41��6�   �� 5      $��1��6   $
��Left=�6(   $��27��6C   $��5,3,0,0q�6O   $
��Wrap=�6`   $ 5q�6t   $��新增型号��6�   $	��Top=�6�   $��60��6�   �� 5      -   5        $��tbReplaceType��5      $��1��6+   $
��Left=�6;   $��30��6V   $��70,0,0,0q�6b    �� TextWrapping$
 Wrap=�6t   $	��Top=�6�   $	��131��6�   �� 5      -   5        $��btReplaceType��5      $��数据生成��6*   $��2��69   $
��Left=�6I   $��26��6d   $��Center=�6q   $��60��6�   $��2,2,0,2q�6�   6�   �� 5      -   5        $��btInsertToDB��5      $��写入数据库��6)   $��2��69   $
��Left=�6I   $��26��6d   $��Center=�6q   $��68��6�   $��75,2,0,2q�6�   6�   �� 5      -   5        $��
cmbAllType��5      $
��Left=�6*   $��30��6E   $��46,0,0,0q�6Q   $	��Top=�6c   $	��156��6{   6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgInfo��5      $��0,5,0,0q�6!   $��1��62      CanUserAddRows .     AutoGenerateColumns .  $
��Left=�6�   $	��597��6�    � ContextMenu 5       �� 5!      .@�5"      m� -   5        $��menuItemExtract��5"   +   $��提取��6   6B   5#         Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ ProductType��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6:   �� *ProductType+  5'      $ 	StationID��6%   	 68   �� *	StationID+  5(      $ StationName��6%   	 6:   �� *StationName+  5)      $ StationVisible��6%   	 6=   �� *StationVisible+  5*      $ Id_Key��6%   	 65   �� *Id_Key+5,      �� 5-   
   $��24��6   $��2��6    $	��Top=�6-   $
��Left=�6E   $	��597��6`   ��5.      �� 5/         MyColorLightBlue
 �� Color#
 �   6"   .@�51      �� -   5        $��tbCurrentRow��51      $��当前行号:0��6,   $��16��6:   �� 52      -   5        $��tbSelectedRows��52      $��16��6.   $
��Wrap=�6:   $��选中行数:0��6N   $
��auto��6\   �� 53      -	   5        $��	tbAllRows��53      $��16��6)   $
��Wrap=�65   $��总行数:0��6I   $
��auto��6V    J� RenderTransformOrigin$ 1.316,0.503&�6c   54      55      56      