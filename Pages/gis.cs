public class SessionState
{
    public UserModel? UsuarioActual { get; set; }
    public bool EstaLogueado => UsuarioActual != null;
}