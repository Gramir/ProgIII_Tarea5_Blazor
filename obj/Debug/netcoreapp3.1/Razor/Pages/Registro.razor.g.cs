#pragma checksum "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Registro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd593e55d9b7dcf55fee4d97f78f9487e28ac18e"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea5_.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using Tarea5_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\_Imports.razor"
using Tarea5_.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/registro")]
    public partial class Registro : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-5 bg-light m-2 justify-content-start");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"p-3 mb-3 bg-primary text-white text-center\">Registrar Usuario</div>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Registro.razor"
                      NuevoUsuario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.AddMarkupContent(11, "<label>Cedula</label>\r\n            ");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "type", "number");
                __builder2.AddAttribute(14, "id", "cedula");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Registro.razor"
                                                                                cedu

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cedu = __value, cedu, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenElement(19, "button");
                __builder2.AddAttribute(20, "type", "button");
                __builder2.AddAttribute(21, "class", "btn btn-info");
                __builder2.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Registro.razor"
                                                                 Api

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(23, "Verificar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.AddMarkupContent(29, "<label>Contraseña</label>\r\n            ");
                __builder2.OpenElement(30, "input");
                __builder2.AddAttribute(31, "type", "password");
                __builder2.AddAttribute(32, "id", "contraseña");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Registro.razor"
                                                                                NuevoUsuario.Clave

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NuevoUsuario.Clave = __value, NuevoUsuario.Clave));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.AddMarkupContent(41, "<label>Nombre</label>\r\n            ");
                __builder2.OpenElement(42, "input");
                __builder2.AddAttribute(43, "type", "text");
                __builder2.AddAttribute(44, "id", "nombre");
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "readonly", true);
                __builder2.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Registro.razor"
                                                                        nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nombre = __value, nombre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-group");
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.AddMarkupContent(54, "<label>Apellido</label>\r\n            ");
                __builder2.OpenElement(55, "input");
                __builder2.AddAttribute(56, "type", "text");
                __builder2.AddAttribute(57, "id", "apellido");
                __builder2.AddAttribute(58, "class", "form-control");
                __builder2.AddAttribute(59, "readonly", true);
                __builder2.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Registro.razor"
                                                                          apellido

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => apellido = __value, apellido));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.AddMarkupContent(66, "\r\n            ");
                __builder2.OpenElement(67, "img");
                __builder2.AddAttribute(68, "src", 
#nullable restore
#line 30 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Registro.razor"
                       foto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(69, "alt", "foto");
                __builder2.AddAttribute(70, "hidden", 
#nullable restore
#line 30 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Registro.razor"
                                                 hide

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(71, "title", "foto");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "text-center p-3 mb-3");
                __builder2.AddMarkupContent(76, "\r\n            ");
                __builder2.OpenElement(77, "button");
                __builder2.AddAttribute(78, "class", "btn btn-info");
                __builder2.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Registro.razor"
                                                   AgregarUsuario

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "hidden", 
#nullable restore
#line 33 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Registro.razor"
                                                                            hide

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(81, " Completar Registro");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(84, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "F:\Users\Kylenz\Documents\Tareas\Programacion III\Tarea5_\Pages\Registro.razor"
       
    public Tarea5_.Models.Usuario NuevoUsuario { get; set; } = new Models.Usuario();
    List<Tarea5_.Models.Usuario> Usuarios = new List<Tarea5_.Models.Usuario>();

    string cedu, nombre, apellido, foto;
    bool hide = true;

    protected override async Task OnInitializedAsync()
    {
        Usuarios = await servicio.GetUsuariosAsync();
    }

    private async Task AgregarUsuario()
    {
        if (cedu == null)
        {
            await Js.InvokeAsync<bool>("confirm", "Debe ingresar una contraseña");
        }
        else
        {
            NuevoUsuario.Cedula = cedu;
            NuevoUsuario.Nombre = nombre;
            NuevoUsuario.Foto = foto;
            NuevoUsuario.Apellido = apellido;

            await servicio.AgregarUsuario(NuevoUsuario);
            await Js.InvokeAsync<bool>("confirm", "Usuario Guardado!");
            nav.NavigateTo("/");
        }


    }

    private async Task Api()
    {
        HttpClient http = new HttpClient();
        Cedula cedula = new Cedula();

        if (cedu == null)
        {
            await Js.InvokeAsync<bool>("confirm", "CEDULA DEBE TENER 11 DIGITOS");
            hide = true;
        }
        else
        {
            if (cedu.Length <= 10 || cedu.Length >= 12)
            {
                await Js.InvokeAsync<bool>("confirm", "CEDULA DEBE TENER 11 DIGITOS");
                hide = true;
            }
            else
            {
                var match = Usuarios.Any(u => u.Cedula == cedu);
                if (match == true)
                {
                    await Js.InvokeAsync<bool>("confirm", "Cedula ya esta registrada");

                }
                else
                {
                    {
                        cedula = await http.GetJsonAsync<Cedula>("https://api.adamix.net/apec/cedula/" + cedu);
                    }

                    if (cedula.ok == false)
                    {
                        await Js.InvokeAsync<bool>("confirm", "CEDULA NO ENCONTRADA");
                        hide = true;
                    }
                    else
                    {
                        nombre = cedula.Nombres;
                        apellido = cedula.Apellido1;
                        foto = cedula.foto;
                        hide = false;
                    }
                }
            }
        }

    }

    public class Cedula
    {
        public string Nombres { get; set; }
        public string Apellido1 { get; set; }
        public bool ok { get; set; }
        public string foto { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Tarea5_.Servicios.UsuarioServicio servicio { get; set; }
    }
}
#pragma warning restore 1591
