using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class QuickLinksEditorWindow : EditorWindow
{
    [MenuItem("Window/Game Engine Programming Quick Links")]
    public static void ShowExample()
    {
        QuickLinksEditorWindow wnd = GetWindow<QuickLinksEditorWindow>();
        wnd.titleContent = new GUIContent("Game Engine Programming Quick Links");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // VisualElements objects can contain other VisualElement following a tree hierarchy
        Label label = new Label("Game Engine Programming Quick Links");
        label.style.fontSize = 24;
        label.style.marginTop = 15;
        label.style.marginBottom = 15;
        label.style.alignSelf = new StyleEnum<Align>(Align.Center);
        root.Add(label);

        // Create button
        Button assignmentButton = new Button();
        assignmentButton.name = "Assignment Brief";
        assignmentButton.text = "Assignment Brief";
        assignmentButton.clicked += AssignmentButton_clicked;
        assignmentButton.style.marginBottom = 5;
        assignmentButton.style.marginTop = 5;
        assignmentButton.style.marginLeft = 15;
        assignmentButton.style.marginRight = 15;
        assignmentButton.style.fontSize = 18;
        assignmentButton.style.paddingTop = 10;
        assignmentButton.style.paddingBottom = 10;
        root.Add(assignmentButton);

        Button moduleHandbookButton = new Button();
        moduleHandbookButton.name = "Module Handbook";
        moduleHandbookButton.text = "Module Handbook";
        moduleHandbookButton.clicked += ModuleHandbookButton_clicked;
        moduleHandbookButton.style.marginBottom = 5;
        moduleHandbookButton.style.marginTop = 5;
        moduleHandbookButton.style.marginLeft = 15;
        moduleHandbookButton.style.marginRight = 15;
        moduleHandbookButton.style.fontSize = 18;
        moduleHandbookButton.style.paddingTop = 10;
        moduleHandbookButton.style.paddingBottom = 10;
        root.Add(moduleHandbookButton);

        Button moduleScheduleButton = new Button();
        moduleScheduleButton.name = "Module Schedule";
        moduleScheduleButton.text = "Module Schedule";
        moduleScheduleButton.clicked += ModuleScheduleButton_clicked;
        moduleScheduleButton.style.marginBottom = 5;
        moduleScheduleButton.style.marginTop = 5;
        moduleScheduleButton.style.marginLeft = 15;
        moduleScheduleButton.style.marginRight = 15;
        moduleScheduleButton.style.fontSize = 18;
        moduleScheduleButton.style.paddingTop = 10;
        moduleScheduleButton.style.paddingBottom = 10;
        root.Add(moduleScheduleButton);
    }

    private void ModuleScheduleButton_clicked()
    {
        Application.OpenURL("https://blackboard.uwe.ac.uk/webapps/blackboard/content/listContent.jsp?course_id=_361722_1&content_id=_9922230_1&mode=reset#");
    }

    private void ModuleHandbookButton_clicked()
    {
        Application.OpenURL("https://blackboard.uwe.ac.uk/webapps/blackboard/content/listContent.jsp?course_id=_361722_1&content_id=_9922230_1&mode=reset#");
    }

    private void AssignmentButton_clicked()
    {
        Application.OpenURL("https://blackboard.uwe.ac.uk/webapps/blackboard/content/listContent.jsp?course_id=_361722_1&content_id=_9922227_1&mode=reset#");
    }
}
