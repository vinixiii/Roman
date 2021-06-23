import React from "react";
import { StyleSheet, Text, View, Image } from "react-native";

export function Projects() {
  return (
    <View style={styles.projects__container}>
      <View style={styles.projects__header}>
        <Image
          source={require("../assets/images/logo.svg")}
          style={styles.projects__headerImg}
        />
        <Text>Olá, professor(a) Vinícius!</Text>
      </View>

      <View style={styles.projects__main}>
        <Text style={styles.projects__title}>Projetos</Text>

        <View style={styles.projects__card}>
          <Text style={styles.projects__cardTitle}>SP Medical Group</Text>
          <Text>Tema: React JS</Text>
          <Text>
            Descrição: Criar uma aplicação de gerenciamento para as clínicas
            médicas
          </Text>
          <Text>Criado por: Vinícius Figueiroa</Text>
        </View>
      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  projects__container: {
    flex: 1,
  },

  projects__main: {
    backgroundColor: "#F6F7F9",
    paddingLeft: 20,
    paddingRight: 20,
    flex: 1,
  },

  projects__content: {
    paddingLeft: 20,
    paddingRight: 20,
  },

  projects__header: {
    backgroundColor: "#fff",
    borderRadius: "0px 0px 6px 6px",
    padding: 10,
    paddingLeft: 20,
    paddingRight: 20,
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",
    boxShadow: "0px 1px 4px rgba(0, 0, 0, 0.25)",
  },

  projects__headerImg: {
    width: 40,
    height: 40,
  },

  projects__title: {
    marginTop: 25,
    marginBottom: 25,
  },

  projects__card: {
    backgroundColor: "#fff",
    minHeight: 159,
  },
});
