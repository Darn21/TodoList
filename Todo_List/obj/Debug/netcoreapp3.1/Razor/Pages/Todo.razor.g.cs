#pragma checksum "C:\Users\sasha\Desktop\TodoList\Todo_List\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cce5531bc1f45fc38666f6e65d3e874fe291e678"
// <auto-generated/>
#pragma warning disable 1591
namespace Todo_List.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sasha\Desktop\TodoList\Todo_List\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sasha\Desktop\TodoList\Todo_List\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sasha\Desktop\TodoList\Todo_List\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sasha\Desktop\TodoList\Todo_List\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sasha\Desktop\TodoList\Todo_List\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sasha\Desktop\TodoList\Todo_List\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sasha\Desktop\TodoList\Todo_List\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sasha\Desktop\TodoList\Todo_List\_Imports.razor"
using Todo_List;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sasha\Desktop\TodoList\Todo_List\_Imports.razor"
using Todo_List.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sasha\Desktop\TodoList\Todo_List\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col");
            __builder.AddMarkupContent(8, "\r\n\r\n            ");
            __builder.OpenElement(9, "h3");
            __builder.AddAttribute(10, "class", "font-italic");
            __builder.AddContent(11, "Todo (");
            __builder.AddContent(12, 
#nullable restore
#line 7 "C:\Users\sasha\Desktop\TodoList\Todo_List\Pages\Todo.razor"
                                           todos.Count(item => !item.IsDone)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table table-striped font-italic");
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.AddMarkupContent(18, @"<thead>
                    <tr>
                        <th><label>Title</label></th>
                        <th><label>Is Done</label></th>
                        <th><label> </label></th>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(19, "tdody");
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 17 "C:\Users\sasha\Desktop\TodoList\Todo_List\Pages\Todo.razor"
                     foreach (var item in todos) 
                    {


#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "                        ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "\r\n                            ");
            __builder.OpenElement(24, "td");
            __builder.AddMarkupContent(25, "\r\n                                ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "style", 
#nullable restore
#line 22 "C:\Users\sasha\Desktop\TodoList\Todo_List\Pages\Todo.razor"
                                              item.IsDone ? "color: grey; text-decoration: line-through;" : "color: black;"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, "  \r\n                                ");
            __builder.AddContent(29, 
#nullable restore
#line 23 "C:\Users\sasha\Desktop\TodoList\Todo_List\Pages\Todo.razor"
                                 item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            ");
            __builder.OpenElement(33, "td");
            __builder.AddMarkupContent(34, "\r\n                                ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "checkbox");
            __builder.AddAttribute(37, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\sasha\Desktop\TodoList\Todo_List\Pages\Todo.razor"
                                                              item.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.IsDone = __value, item.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                            ");
            __builder.OpenElement(41, "td");
            __builder.AddMarkupContent(42, "\r\n                               ");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "class", "btn btn-info");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\sasha\Desktop\TodoList\Todo_List\Pages\Todo.razor"
                                                                      (() => DeleteTodo(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                            \r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 34 "C:\Users\sasha\Desktop\TodoList\Todo_List\Pages\Todo.razor"

                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "row");
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col");
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "class", "form-control");
            __builder.AddAttribute(61, "placeholder", "Type something todo");
            __builder.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\sasha\Desktop\TodoList\Todo_List\Pages\Todo.razor"
                                                                                         newTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTodo = __value, newTodo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col");
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "class", "btn btn-primary");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\sasha\Desktop\TodoList\Todo_List\Pages\Todo.razor"
                                                              AddTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(72, "Add todo");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\sasha\Desktop\TodoList\Todo_List\Pages\Todo.razor"
       
    private IList<TodoItem> todos = new List<TodoItem>();
    private string newTodo;

    private void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new TodoItem {Title = newTodo});
            newTodo = string.Empty;
        }
    }
    private void DeleteTodo(TodoItem deletedItem)
    {
        todos.Remove(deletedItem); 
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
