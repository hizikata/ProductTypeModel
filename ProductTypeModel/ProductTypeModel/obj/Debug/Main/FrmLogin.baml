   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	       UI.FrmLogin   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	     � WindowStyle$
  None=�6(    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   4    � Title$ 用户登录��5   	   $��265.518��6   $��442.242��6'   {�.  � Icon$, &/UI;component/Resources/Icons/Logo.ico��6H   ��5	      �� 5
   
    �� ImageSource$- '/UI;component/Resources/Icons/Login.png��6   .��5      � ��5   
   �� 5       � ColumnDefinitions 5   
   �� 5      $	��48* �6   �� 5      $	��58* �6   �� 5      $
��115* �6    � RowDefinitions 5   
   �� 5      $	��65* �6   �� 5      $	��36* �6   �� 5      $	��36* �6   �� 5      $	��36* �6   �� 5      $	��94* �6   .+�5   
   �� $��26��6   $��	31,10,0,0q�6    $��1��63   $
��Wrap=�6@   $��
用户名:��6T   $	��Top=�6`   $��16(�6x   $��YouYuan)�6�   $
��Bold"�6�   ��6�   Z� �� 5   
   $��39,8,0,0q�6   $��2��6&   $
��Wrap=�63   $��密码:��6G   $��16(�6S   $��YouYuan)�6a   $
��Bold"�6v   ��6�   Z� �� 5   
   -   5        $��
TBUserName��5      $��1��6$   $��28��64   $��0,4,0,0q�6@   $��1��6Q    �� TextWrapping$
 Wrap=�6^   $	��Top=�6s   $��Stretch=�6�   $
��Auto��6�   �� 5    
   -   5        $��
TBPassword��5       $��1��6$   $��28��64   $��0,4,0,0q�6@   $��2��6Q   $
 Wrap=�6^   $	��Top=�6s   $��Stretch=�6�   $
��Auto��6�   �� 5!   
   -   5        $��BTCancel��5!      $��取消��6!   $��25��6.   $��61,10,229,0q�6:   $��3��6O   $��YouYuan)�6\   $	��Top=�6q   $��1��6�   $��14(�6�   $��2��6�   6�   �� 5"   
   -   5        $��BTLogin��5"      $��2��6    $��登录��64   $
��Left=�6A   $��25��6\   $��	79,10,0,0q�6h   $��3��6{   $��YouYuan)�6�   $	��Top=�6�   $��56��6�   $��14(�6�   6�   5$      5%      