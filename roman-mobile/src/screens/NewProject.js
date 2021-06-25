//Packages
import React, { useState } from "react";
import { StyleSheet, View, Text, TextInput } from "react-native";
import { LinearGradient } from "expo-linear-gradient";
import AsyncStorage from "@react-native-async-storage/async-storage";
import jwtDecode from "jwt-decode";

//Components
import { Button } from "../components/Button";
import api from "../services/api";

export function NewProject({ navigation }) {
  const [title, setTitle] = useState("");
  const [theme, setTheme] = useState("");
  const [description, setDescription] = useState("");

  async function registerNewProject() {
    try {
      const token = await AsyncStorage.getItem("token");

      await api.post(
        "/projetos",
        {
          idProfessor: jwtDecode(token).jti,
          idTema: theme,
          titulo: title,
          descricao: description,
        },
        {
          headers: {
            Authorization: "Bearer " + token,
          },
        }
      );

      navigation.navigate("Projects");
      console.log("Foi");
    } catch (error) {}
  }

  return (
    <View style={styles.container}>
      <View style={styles.main}>
        <Text style={styles.title}>Novo projeto</Text>

        <View style={styles.form}>
          <View style={styles.formField}>
            <Text style={styles.formLabel}>Título</Text>
            <TextInput
              style={styles.formInput}
              // keyboardType="email-address"
              onChangeText={(title) => setTitle(title)}
            />
          </View>

          <View style={styles.formField}>
            <Text style={styles.formLabel}>Tema</Text>
            <TextInput
              style={styles.formInput}
              // keyboardType="password"
              onChangeText={(theme) => setTheme(theme)}
            />
          </View>

          <View style={styles.formField}>
            <Text style={styles.formLabel}>Descrição</Text>
            <TextInput
              style={styles.formInput}
              // keyboardType="email-address"
              onChangeText={(description) => setDescription(description)}
            />
          </View>
        </View>
      </View>

      <LinearGradient
        colors={["rgba(246, 247, 249, 0.1)", "rgba(255, 255, 255, 1)"]}
        style={styles.footer}
      >
        <Button onPress={registerNewProject}>Concluído</Button>
      </LinearGradient>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    backgroundColor: "#F6F7F9",
    flex: 1,
  },

  main: {
    flex: 1,
    paddingLeft: 20,
    paddingRight: 20,
  },

  title: {
    fontSize: 28,
    color: "#33547D",
    marginTop: 25,
    marginBottom: 25,
  },

  formField: {
    marginBottom: 20,
  },

  formLabel: {
    fontSize: 18,
    color: "#33547D",
    marginBottom: 8,
  },

  formInput: {
    backgroundColor: "#fff",
    borderRadius: 6,
    height: 60,
    paddingLeft: 20,
  },
});
