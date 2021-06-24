//Packages
import React from "react";
import { createStackNavigator } from "@react-navigation/stack";

//Screens
import { Projects } from "./Projects";
import { NewProject } from "./NewProject";

import { Themes } from "./Themes";
import { NewTheme } from "./NewTheme";

import { More } from "./More";
import { Profile } from "./Profile";

//Components
import { Header } from "../components/Header";

const Stack = createStackNavigator();

export function ThemesNavigator() {
  return (
    <Stack.Navigator>
      <Stack.Screen
        name="Themes"
        component={Themes}
        options={{
          headerTitle: (props) => <Header {...props} />,
        }}
      />
      <Stack.Screen
        name="NewTheme"
        component={NewTheme}
        options={{
          headerTitle: (props) => (
            <Header secondaryPageTitle={"Temas"} {...props} />
          ),
          headerTintColor: "#33547D",
          headerTitleStyle: {
            color: "red",
            fontSize: 24,
          },
        }}
      />
    </Stack.Navigator>
  );
}

export function ProjectsNavigator() {
  return (
    <Stack.Navigator>
      <Stack.Screen
        name="Projects"
        component={Projects}
        options={{
          headerTitle: (props) => <Header {...props} />,
        }}
      />
      <Stack.Screen
        name="NewProject"
        component={NewProject}
        options={{
          headerTitle: (props) => (
            <Header secondaryPageTitle={"Projetos"} {...props} />
          ),
          headerTintColor: "#33547D",
          headerTitleStyle: {
            color: "red",
            fontSize: 24,
          },
        }}
      />
    </Stack.Navigator>
  );
}

export function MoreNavigator() {
  return (
    <Stack.Navigator>
      <Stack.Screen
        name="More"
        component={More}
        options={{
          headerTitle: (props) => <Header {...props} />,
        }}
      />
      <Stack.Screen
        name="Profile"
        component={Profile}
        options={{
          headerTitle: (props) => (
            <Header secondaryPageTitle={"Mais"} {...props} />
          ),
          headerTintColor: "#33547D",
          headerTitleStyle: {
            color: "red",
            fontSize: 24,
          },
        }}
      />
    </Stack.Navigator>
  );
}
