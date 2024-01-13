# GenView

### Code-generated Views for Unity UI (UGUI)

## Disclaimer

The project isn't an actual tool for Unity development. It kinda works, but I made it just for fun of problem solving and research and using it in real-life projects 
can produce more problems then it solves.  

## Without GenView - classic approach

```csharp
public class ExampleView : MonoBehaviour
{
    // all the fields that you have to declare and drag'n'drop references
    // in unity's inspector
    public Image background;
    public Text text;
    public Button button;
    
    // in this example logic isn't separated from view, 
    // but you can imagine what it would look like
    void Awake()
    {
        background.color = Color.red;
        text.text = "Hello World!"
        button.OnClick.AddListener(() => Debug.Log("Button Clicked"));
    }
}
```

## With GenView

```csharp
public class ExampleController : MonoBehaviour
{
    // all you have to do is build your UI in scene and generate code
    // then all is left is get a reference to view and write actual logic 
    public GeneratedExampleView view;
    
    void Awake()
    {
        view.Background.Image.color = Color.red;
        view.Container.Text.text = "Hello World!"
        view.Container.Button.OnClick.AddListener(() => Debug.Log("Button Clicked"));
    }
}
```

## Why this approach?

The idea is sort of inspired from WPF/WinForms/MAUI where XAML code is inspected and C# side is code-generated.

UGUI is just a pain of drag'n'dropping everything after you declared everything and in larger UIs it's annoying.

UI Toolkit creates inconsistency between Controller and View, because querying using hard-coded strings.

While making the tool I was focusing on ability to utilize code autocompletion that became very important in modern development 

## Guide

Put ViewGenerationAssistant on root of your UI view. Fill Directory, Namespace and ClassName for your needs. 

If your target folder isn't under any assemblies, just leave Assembly Name blank - Assembly-CSharp is going to be used implicitly

![image](https://github.com/DavidNightinga1e/GenView/assets/43321460/675042e2-f5e2-4257-8b2b-14ddcddc8207)

1. Generate C# View button analyzes your hierarchy and generates file. Wait for compilation process to finish after pushing the button
2. Add Component adds generated component. This will work only when generation is complete. Also this button serializes all the references. Note that between this steps you are not allowed to make any changes in UI hierarchy or it will fail. 
3. Remove component is just a shortcut. Won't work if type names differ 
4. Delete file locates file by concating directory and class name. This is supposed to be used if compilation failed and you don't want to seek for this broken file all over the project

In Runtime folder there is settings file.

![image](https://github.com/DavidNightinga1e/GenView/assets/43321460/10390eb4-5134-400b-ace6-827a8b61b302)

Hide In Inspector tick just adds HideInInspector attribute to all generated fields. 

Inner Class Separator is a symbol that is put between child names. Because fields differ in all the children class names are constructed of path to child.
Look at Example View in repository to understand it better
